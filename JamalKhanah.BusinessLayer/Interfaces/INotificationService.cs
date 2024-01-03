
using JamalKhanah.Core.DTO.NotificationModel;
using JamalKhanah.Core.Entity.ChatAndNotification;

namespace JamalKhanah.BusinessLayer.Interfaces;

public interface INotificationService
{
    Task<ResponseModel> SendNotification(NotificationModel notificationModel);
}