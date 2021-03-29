using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMidProject.BusinessLayer
{
    public class OrderModel
    {
        public int orderId;
        public String clientName;
        public String phoneNumber;
        public String serviceType;
        public String dimensions;
        public int quantity;
        public byte[] image;

        public OrderModel(
        int orderId,
        String clientName,
        String phoneNumber,
        String serviceType,
        String dimensions,
        int quantity,
        byte[] image
        )
        {
            this.orderId = orderId;
            this.clientName = clientName;
            this.phoneNumber = phoneNumber;
            this.serviceType = serviceType;
            this.dimensions = dimensions;
            this.quantity = quantity;
            this.image = image;

        }
    }
}