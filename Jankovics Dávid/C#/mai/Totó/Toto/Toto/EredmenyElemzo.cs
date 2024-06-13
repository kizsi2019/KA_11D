public class EredmenyElemzo
{
    public static bool NemvoltDontetlenMerkozes(string eredmenyek)
    {
        return !eredmenyek.Contains("X");
    }
}