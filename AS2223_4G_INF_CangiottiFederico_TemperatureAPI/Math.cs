namespace AS2223_4G_INF_CangiottiFederico_TemperatureAPI
{
    public enum Status
    {
        OK,
        ERROR
    }

    public class MathResponse
    {
        public Status status { get; set; }
        public string message { get; set; }

        public MathResponse(Status status, string message)
        {
            this.status = status;
            this.message = message;
        }
    }
}
