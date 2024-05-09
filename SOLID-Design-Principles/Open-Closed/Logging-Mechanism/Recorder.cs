public class Recorder
{
    private readonly IRecorder recorder;

    public Recorder(IRecorder recorder)
    {
        this.recorder = recorder;
    }

    public void LogMesage(string message)
    {
        this.recorder.LogMessage(message);
    }
}