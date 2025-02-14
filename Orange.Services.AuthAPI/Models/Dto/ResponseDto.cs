namespace Orange.Services.AuthAPI.Models.Dto
{
    public class ResponseDto
    {
        public object? Result { get; set; }  // အကြောင်းအရာ (Data Result) ကို သိမ်းမည့် Property

        public bool IsSuccess { get; set; } = true;  // Success/Failure ကို သိမ်းမည့် Property (Default: true)

        public string Message { get; set; } = "";  // Message ထည့်နိုင်မည့် Property (Default: Empty String)
    }
}
