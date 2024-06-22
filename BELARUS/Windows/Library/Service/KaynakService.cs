namespace BELARUS.Service
{
    public class KaynakService : ServiceBase<BELARUS.Data.Kaynak>, IKaynakService
    {
        public KaynakService()
            : base()
        { }

        public override void Update(BELARUS.Data.Kaynak entity)
        {
            base.Update(entity);
        }
    }

    public interface IKaynakService : IService<BELARUS.Data.Kaynak>
    {
    }
}