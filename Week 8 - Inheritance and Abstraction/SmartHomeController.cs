

class SmartHomeController
{
    private int controllerID;
    private string location;
    private bool status;

    public int ControllerID
    {
        get { return controllerID; }
        set { controllerID = value; }
    }

    public string Location
    {
        get { return location; }
        set { location = value; }
    }

    public bool Status
    {
        get { return status; }
        set { status = value; }
    }

    SmartHomeController(int controllerID, string location, bool status)
    {
        this.ControllerID = controllerID;
        this.Location = location;
        this.Status = status;
    }

}
