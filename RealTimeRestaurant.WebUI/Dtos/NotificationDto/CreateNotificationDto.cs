﻿namespace RealTimeRestaurant.WebUI.Dtos.NotificationDto
{
    public class CreateNotificationDto
    {
        public string Type { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
