using System.Reflection.Emit;

namespace LucasTechnologyServices.Module.Infrastructure.Data
{
    public interface ICustomModelBuilder
    {
        void Build(ModuleBuilder modelBuilder);
    }
}
