using Confluent.Kafka;

namespace KafkaWindowsChat;

public partial class Form1 : Form
{
    private readonly ProducerConfig producerConfig;
    private readonly ConsumerConfig consumerConfig;

    public Form1()
    {
        InitializeComponent();

        producerConfig = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        consumerConfig = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = Guid.NewGuid().ToString(),
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        StartConsumer();
    }

    private async void btnSend_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(rtbMessage.Text))
            return;

        using var producer =
            new ProducerBuilder<Null, string>(producerConfig).Build();

        await producer.ProduceAsync(
            "chat-message",
            new Message<Null, string>
            {
                Value = rtbMessage.Text
            });

        MessageBox.Show("Message Sent Successfully");

        rtbMessage.Clear();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        rtbMessage.Clear();
    }

    private void StartConsumer()
    {
        Task.Run(() =>
        {
            using var consumer =
                new ConsumerBuilder<Ignore, string>(consumerConfig).Build();

            consumer.Subscribe("chat-message");

            while (true)
            {
                try
                {
                    var result = consumer.Consume();

                    Invoke(() =>
                    {
                        rtbMessage.AppendText(
                            Environment.NewLine +
                            "Received : " +
                            result.Message.Value);
                    });
                }
                catch
                {
                }
            }
        });
    }
}