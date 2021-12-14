using System.Runtime.Serialization;

namespace HelloWordService
{
    public class HelloObject
    {
        [DataMember]
            public bool happyHello { get; set; } = false;

        [DataMember]
        public string helloMessage { get; set; } = "Hiya";
    }
}