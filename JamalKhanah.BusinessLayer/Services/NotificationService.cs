using JamalKhanah.BusinessLayer.Interfaces;
using Microsoft.Extensions.Options;
using JamalKhanah.Core.DTO.NotificationModel;
using JamalKhanah.Core.Helpers;
using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Hosting;

namespace JamalKhanah.BusinessLayer.Services;

public class NotificationService : INotificationService
{
    private readonly FcmNotificationSetting _fcmNotificationSetting;
    private IHostingEnvironment env;
    public string result;

    public NotificationService(IHostingEnvironment env,IOptions<FcmNotificationSetting> settings)
    {
        this.env = env;
        _fcmNotificationSetting = settings.Value;
    }

    public async Task<ResponseModel> SendNotification(NotificationModel notificationModel)
    {
        FirebaseApp app;
        try
        {
            app = FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Auth.json")),
            });
        }
        catch (Exception ex)
        {
            app = FirebaseApp.GetInstance("myApp");
        }
        var fcm = FirebaseAdmin.Messaging.FirebaseMessaging.GetMessaging(app);
        Message message = new Message()
        {
            Notification = new Notification
            {
                Title = notificationModel.Title,
                Body = notificationModel.Body,
            },
            Data = new Dictionary<string, string>()
                 {
                 },

            Token = notificationModel.DeviceId
        };

        var result = await fcm.SendAsync(message);
        ResponseModel response = new ResponseModel();
        //try
        //{
        //    using (var client = new HttpClient())
        //    {
        //        var firebaseOptionsServerId = _fcmNotificationSetting.ServerKey;
        //        var firebaseOptionsSenderId = _fcmNotificationSetting.SenderId;

        //        client.BaseAddress = new Uri("https://fcm.googleapis.com");
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization",
        //            $"key={firebaseOptionsServerId}");
        //        client.DefaultRequestHeaders.TryAddWithoutValidation("Sender", $"id={firebaseOptionsSenderId}");


        //        var data = new
        //        {
        //            to = notificationModel.DeviceId,
        //            data = new
        //            {
        //                body = notificationModel.Body,
        //                title = notificationModel.Title,
        //            },
        //            priority = "high"
        //        };

        //        var json = JsonConvert.SerializeObject(data);
        //        var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
        //        var result = await client.PostAsync("/fcm/send", httpContent);
        if (result!=null)
        {
            response.IsSuccess = true;
            response.Message = "Notification sent successfully";
            return response;
        }
        else
        {
            response.IsSuccess = false;
            response.Message = "Error";
            return response;
        }
        //    }
        //}
        //catch (Exception ex)
        //    {
        //    response.IsSuccess = false;
        //    response.Message = $"Something went wrong : {ex.Message}";
        //    return response;
        //}

    }
}