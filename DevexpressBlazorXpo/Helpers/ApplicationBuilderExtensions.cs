using DevExpress.Xpo;
using DevexpressBlazorXpo.DataAccess;

namespace DevexpressBlazorXpo.Helpers
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseXpoDemoData(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                UnitOfWork uow = scope.ServiceProvider.GetService<UnitOfWork>();
                DemoDataHelper.Seed(uow);
            }
            return app;
        }
    }
}
