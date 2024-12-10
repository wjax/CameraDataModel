namespace CameraControlDataModel.Lens;

public delegate void LensStateChangedDelegate(int lensIdx, Parameter parameter, double value);
public delegate void LensConnectedDelegate(int lensIdx, bool connected);

public interface ILensController
{
    public event LensStateChangedDelegate LensStateChangedEvent;
    public event LensConnectedDelegate LensConnectedEvent;

    public int Idx { get; init; }
    public bool SetLensParameter(Parameter parameter, double value);
    public double GetLensCachedParameter(Parameter parameter);
    public void RefreshLensParameter(Parameter parameter);
    
    //bool CheckParameterWithinRange(string parameters, double value);
}