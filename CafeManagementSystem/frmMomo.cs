using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using ZXing;
using ZXing.Common;

using System.Net;

namespace CafeManagementSystem
{
    public partial class frmMomo : Form
    {
        string endpoint = "https://test-payment.momo.vn/v2/gateway/api/create";
        string partnerCode = "MOMO5RGX20191128"; // thay bang key cua minh
        string accessKey = "M8brj9K6E22vXoDB";   // thay bang key cua minh
        string serectkey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4"; // thay bang key cua minh
        string order_id;

        public frmMomo()
        {
            InitializeComponent();
            lbReturn.Text = "0";
            lbTotal.Text = frmPlaceOrder.total.ToString();
            txtReceived.Text = frmPlaceOrder.total.ToString();
            lbOrderID.Text = frmPlaceOrder.orderID;
        }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private void bGenerate_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(txtReceived.Text)*1000;
            string orderInfo = "TEST";
            string redirectUrl = "https://webhook.site/b3088a6a-2d17-4f8d-a383-71389a6c600b";//Link trang Web cua doanh nghiep
            string ipnUrl = "https://webhook.site/b3088a6a-2d17-4f8d-a383-71389a6c600b";//
            string requestType = "captureWallet";

            string orderId = lbOrderID.Text;
            order_id = orderId;
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";
            ;
            //Before sign HMAC SHA256 signature
            string rawHash = "accessKey=" + accessKey +
                "&amount=" + amount +
                "&extraData=" + extraData +
                "&ipnUrl=" + ipnUrl +
                "&orderId=" + orderId +
                "&orderInfo=" + orderInfo +
                "&partnerCode=" + partnerCode +
                "&redirectUrl=" + redirectUrl +
                "&requestId=" + requestId +
                "&requestType=" + requestType
                ;

            log.Debug("rawHash = " + rawHash);

            MoMoSecurity crypto = new MoMoSecurity();
            //sign signature SHA256
            string signature = crypto.signSHA256(rawHash, serectkey);
            log.Debug("Signature = " + signature);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", "Test" },
                { "storeId", "MomoTestStore" },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                { "ipnUrl", ipnUrl },
                { "lang", "en" },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature }

            };
            log.Debug("Json request to MoMo: " + message.ToString());
            string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());

            JObject jmessage = JObject.Parse(responseFromMomo);
            log.Debug("Return from MoMo: " + jmessage.ToString());
            DialogResult result = MessageBox.Show("                                                                                                                                                                                                                                                                                     Ấn OK để tới trang thanh toán", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //yes...
                //MessageBox.Show(jmessage.GetValue("qrCodeUrl").ToString()); **tra ve wf nhung yeu cau xac thuc tk doanh nghiep



                //Change the string 
                string modifiedString = ModifyMoMoString(jmessage.GetValue("deeplink").ToString(), true, "qr");
                txtLink.Text = modifiedString;

                string url = txtLink.Text;

                // Generate QR code
                Bitmap qrCodeImage = GenerateQRCode(url);

                // Display QR code in PictureBox
                qrMomo.Image = qrCodeImage;


            }
            else if (result == DialogResult.Cancel)
            {
                //no...
            }


        }

        private void bCheckStatus_Click(object sender, EventArgs e)
        {
            string partnerCode = this.partnerCode; // Thay bằng mã đối tác của bạn
            string requestId = Guid.NewGuid().ToString();
            string accesskey = this.accessKey;
            string orderIdToCheck = this.order_id; // Thay bằng mã đơn hàng cần kiểm tra

            // Tạo chuỗi signature
            string signatureData = $"accessKey={accesskey}&orderId={orderIdToCheck}&partnerCode={partnerCode}&requestId={requestId}";
            string signature = CalculateHmacSHA256Signature(signatureData, this.serectkey);

            // Tạo JSON request
            JObject request = new JObject
            {
                { "partnerCode", partnerCode },
                { "requestId", requestId },
                { "orderId", orderIdToCheck },
                { "signature", signature },
                { "lang", "en" }
            };

            // Gửi request đến Momo và xử lý response ở đây
            string response = SendRequestToMomo("https://test-payment.momo.vn/v2/gateway/api/query", request.ToString());

            // Xử lý response từ Momo ở đây, bạn có thể hiển thị thông tin giao dịch hoặc thông báo cho người dùng.
            JObject jmessage = JObject.Parse(response);

            string kq = jmessage.GetValue("resultCode").ToString();

            if (kq == "0")
                MessageBox.Show("Giao dịch thành công!");
            else
                MessageBox.Show("Giao dịch thất bại");
        }
        private string CalculateHmacSHA256Signature(string data, string key)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(key)))
            {
                byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        // Hàm gửi request đến Momo và nhận response
        private string SendRequestToMomo(string url, string requestData)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    return client.UploadString(url, "POST", requestData);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi gửi request
                return ex.Message;
            }
        }

        public static string ModifyMoMoString(string inputString, bool isScanQR, string serviceType)
        {
            // Split the input string by '&' to extract individual parameters
            string[] parameters = inputString.Split('&');

            // Iterate through each parameter and update the values of 'isScanQR' and 'serviceType'
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].StartsWith("isScanQR="))
                {
                    // Update 'isScanQR' parameter
                    parameters[i] = "isScanQR=" + isScanQR.ToString().ToLower();
                }
                else if (parameters[i].StartsWith("serviceType="))
                {
                    // Update 'serviceType' parameter
                    parameters[i] = "serviceType=" + serviceType;
                }
            }

            // Join the modified parameters back into a single string
            string modifiedString = string.Join("&", parameters);
            return modifiedString;
        }

       

        private Bitmap GenerateQRCode(string url)
        {
            // Encoding options
            EncodingOptions options = new EncodingOptions
            {
                Width = 300, // Width of the QR code image
                Height = 300, // Height of the QR code image
                Margin = 0 // Margin around the QR code
            };

            // Generate QR code
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;

            Bitmap qrCodeImage = writer.Write(url);

            return qrCodeImage;
        }
    }
}
