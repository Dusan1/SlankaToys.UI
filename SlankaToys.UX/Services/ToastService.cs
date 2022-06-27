using System;
using System.Timers;

namespace SlankaToys.UX.Services
{
    public class ToastService : IDisposable
    {
        public ToastService()
        {
        }

        public event Action<string, ToastType> OnShow;
        public event Action OnHide;
        private Timer Countdown;

        public void ShowToast(string message, ToastType type)
        {
            OnShow?.Invoke(message, type);
            StartCountdown();
        }

        private void StartCountdown()
        {
            SetCountdown();

            if (Countdown.Enabled)
            {
                Countdown.Stop();
                Countdown.Start();
            }
            else
            {
                Countdown.Start();
            }
        }

        private void SetCountdown()
        {
            if (Countdown == null)
            {
                Countdown = new Timer(500);
                Countdown.Elapsed += HideToast;
                Countdown.AutoReset = false;
            }
        }

        private void HideToast(object source, ElapsedEventArgs args)
        {
            OnHide?.Invoke();
        }



        public void Dispose()
        {
            Countdown?.Dispose();
        }
    }
}
