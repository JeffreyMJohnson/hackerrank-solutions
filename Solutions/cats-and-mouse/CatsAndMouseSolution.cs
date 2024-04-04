public class CatsAndMouseSolution
{
    public static string catAndMouse(int catA, int catB, int mouse)
    {
        int catADistance = DistanceToMouse(catA, mouse);
        int catBDistance = DistanceToMouse(catB, mouse);

        if(catADistance == catBDistance) return "Mouse C";
        if(catADistance < catBDistance) return "Cat A";
        return "Cat B";

    }

    private static int DistanceToMouse(int catPosition, int mousePosition)
    {
        //distance = x2-x1 -> mouse - cat
        return Math.Abs(mousePosition-catPosition);
    }
}