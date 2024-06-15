public class ButtonDamage : ButtonDemo
{
    protected override void Action()
    {
        PersonHealth.Reduce(Amount);
    }
}
