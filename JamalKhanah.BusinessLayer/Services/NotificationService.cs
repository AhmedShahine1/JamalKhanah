using CorePush.Google;
using JamalKhanah.BusinessLayer.Interfaces;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using JamalKhanah.Core.DTO.NotificationModel;
using JamalKhanah.Core.Helpers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using JamalKhanah.Core.Entity.ChatAndNotification;
using Microsoft.AspNetCore.Mvc;
using JamalKhanah.RepositoryLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JamalKhanah.BusinessLayer.Services;

public class NotificationService : INotificationService
{
    private readonly FcmNotificationSetting _fcmNotificationSetting;

    public NotificationService(IOptions<FcmNotificationSetting> settings)
    {
        _fcmNotificationSetting = settings.Value;
    }

    public async Task<ResponseModel> SendNotification(NotificationModel notificationModel)
    //{
    //    ResponseModel response = new ResponseModel();
    //    try
    //    {
    //        FcmSettings settings = new FcmSettings()
    //        {
    //            SenderId = _fcmNotificationSetting.SenderId,
    //            ServerKey = _fcmNotificationSetting.ServerKey
    //        };

    //        HttpClient httpClient = new HttpClient();
    //        string authorizationKey = string.Format("key={0}", settings.ServerKey);
    //        string deviceToken = notificationModel.DeviceId;
    //        httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authorizationKey);
    //        httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Sender",string.Format("id={0}", settings.SenderId));
    //        httpClient.DefaultRequestHeaders.Accept
    //            .Add(new MediaTypeWithQualityHeaderValue("application/json"));

    //        GoogleNotification.DataPayload dataPayload = new GoogleNotification.DataPayload();
    //        dataPayload.Title = notificationModel.Title;
    //        dataPayload.Body = notificationModel.Body;
    //        GoogleNotification notification = new GoogleNotification();
    //        notification.Notification = dataPayload;
    //        notification.Token = notificationModel.DeviceId;
    //        //notification.Notification = dataPayload;

    //        var fcm = new FcmSender(settings, httpClient);
    //        var fcmSendResponse = await fcm.SendAsync(deviceToken, notification);

    //        if (fcmSendResponse.IsSuccess())
    //        {
    //            response.IsSuccess = true;
    //            response.Message = "Notification sent successfully";
    //            return response;
    //        }
    //        else
    //        {
    //            response.IsSuccess = false;
    //            response.Message = fcmSendResponse.Results[0].Error;
    //            return response;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        response.IsSuccess = false;
    //        response.Message = $"Something went wrong : {ex.Message}";
    //        return response;
    //    }
    //}
    {
        ResponseModel response = new ResponseModel();
        try
        {
            using (var client = new HttpClient())
            {
                var firebaseOptionsServerId = _fcmNotificationSetting.ServerKey;
                var firebaseOptionsSenderId = _fcmNotificationSetting.SenderId;

                client.BaseAddress = new Uri("https://fcm.googleapis.com");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization",
                    $"key={firebaseOptionsServerId}");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Sender", $"id={firebaseOptionsSenderId}");


                var data = new
                {
                    to = notificationModel.DeviceId,
                    data = new
                    {
                        body = notificationModel.Body,
                        title = notificationModel.Title,
                    },
                    priority = "high"
                };

                var json = JsonConvert.SerializeObject(data);
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("/fcm/send", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    response.IsSuccess = true;
                    response.Message = "Notification sent successfully";
                    return response;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = result.Content.ToString();
                    return response;
                }
            }
        }
        catch (Exception ex)
            {
            response.IsSuccess = false;
            response.Message = $"Something went wrong : {ex.Message}";
            return response;
        }

    }
}