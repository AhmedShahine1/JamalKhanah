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
            },"myApp");
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