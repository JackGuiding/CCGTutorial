public class IDService {

    int roleIDRecord;
    int bulletIDRecord;

    public int GetRoleID()
    {
        return ++roleIDRecord;
    }

}