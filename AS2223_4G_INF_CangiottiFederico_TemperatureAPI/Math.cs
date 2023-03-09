using System.Text.Json.Serialization;

namespace AS2223_4G_INF_CangiottiFederico_TemperatureAPI
{
    public enum Status
    {
        OK,
        ERROR
    }

    public class MathResult
    {
        // converts enumeration values to and from strings
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status status { get; set; }
        public string message { get; set; }

        public MathResult(Status status, string message = "")
        {
            this.status = status;
            this.message = message;
        }
    }
}
