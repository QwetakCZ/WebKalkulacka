namespace WebProject.Services
{
    public class EventServices
    {
        public event EventHandler OnReload;

        public void Reload()
        {
            OnReload?.Invoke(this, EventArgs.Empty);
        }
    }
}
