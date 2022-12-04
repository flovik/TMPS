namespace BehavioralDesignPatterns.TemplateMethod;

public abstract class BreadTemplate
{
    //algorithm of preparing bread
    public void PrepareBread()
    {
        Scaling();
        ProofingYeast();
        Mixing();
        Kneading();
        BulkFerment();
        Shaping();
        Baking();
    }

    protected abstract void Scaling();
    protected virtual void ProofingYeast() {} //optional step
    protected abstract void Mixing();
    protected abstract void Kneading();
    protected abstract void BulkFerment();
    protected abstract void Shaping();
    protected abstract void Baking();


}