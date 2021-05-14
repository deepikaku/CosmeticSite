using System.Runtime.Serialization;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Pending")]
        Pending,

        [EnumMember(Value = "Processing")]
        Processing,

        [EnumMember(Value = "Quality Check")]
        QualityCheck,

        [EnumMember(Value = "Shipped")]
        Shipped,

        [EnumMember(Value = "Dispatched")]
        Dispatched,

        [EnumMember(Value = "Sent To Courier")]
        ToCourierDispatched,

        [EnumMember(Value = "Courier Move")]
        CourierMove,

        [EnumMember(Value = "Reach to Customer")]
        CustomerReach,

        [EnumMember(Value = "Delievered")]
        Delievered,

        [EnumMember(Value = "Payment Received")]
        PaymentRecevied,

        [EnumMember(Value = "Payment Failed")]
        PaymentFailed,

        [EnumMember(Value = "Payment Processing")]
        PaymentProcessing
    }
}