using System.Text.Json.Serialization;

namespace AS2223_4G_INF_CangiottiFederico_TemperatureAPI
{
    public enum Status
    {
        OK,
        ERROR,
        WARNING
    }

    public class MathResult
    {
        // converts enumeration values to and from strings
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }
        public string Message { get; set; }

        public MathResult(Status status, string message = "")
        {
            this.Status = status;
            this.Message = message;
        }
    }
}
