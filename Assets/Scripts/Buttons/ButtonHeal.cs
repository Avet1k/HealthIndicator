public class ButtonHeal : ButtonDemo
{
    protected override void Action()
    {
        PersonHealth.Add(Amount);
    }
}
