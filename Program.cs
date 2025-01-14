using GRCPSERVICE_C_;
using Grpc.Net.Client;
var channel = GrpcChannel.ForAddress("http://localhost:5291");
var client = new Greeter.GreeterClient(channel);

var reply = client.SayHello(new HelloRequest { Name = "World" });
Console.WriteLine("Greeting: " + reply.Message);
