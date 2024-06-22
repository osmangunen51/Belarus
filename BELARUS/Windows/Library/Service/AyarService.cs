namespace BELARUS.Service
{
    public class AyarService : ServiceBase<BELARUS.Data.Ayar>, IAyarService
    {
        public AyarService()
            : base()
        { }

        public override void Update(BELARUS.Data.Ayar entity)
        {
            base.Update(entity);
        }
    }

    public interface IAyarService : IService<BELARUS.Data.Ayar>
    {
    }
}