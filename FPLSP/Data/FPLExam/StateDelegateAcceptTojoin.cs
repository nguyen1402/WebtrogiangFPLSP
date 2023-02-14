namespace FPLSP.Data.FPLExam
{
    public class StateDelegateAcceptTojoin
    {
        public string SelectedIdUser { get; set; }
        public string DeclineIdUser { get; set; }
        public string ResetTimerUser { get; set; }
        public string IdKicker { get; set; }
        public string IdKillProcess { get; set; }
        public event EventHandler OnChange;
        public void AccpetToJoin(string IdUser)
        {
            if (!string.IsNullOrEmpty(IdUser))
            {
                SelectedIdUser = IdUser;
            }
            NotifyStateChanged();
        }
        public void Decline(string IdUser)
        {
            if (!string.IsNullOrEmpty(IdUser))
            {
                DeclineIdUser = IdUser;
            }
            NotifyStateChanged();
        }
        public void HotReloadTimer(string reset)
        {
            if (!string.IsNullOrEmpty(reset))
            {
                ResetTimerUser = reset;
            }
            NotifyStateChanged();
        }
        public void Kicker(string idkicker)
        {
            if (!string.IsNullOrEmpty(idkicker))
            {
                IdKicker = idkicker;
            }
            NotifyStateChanged();
        }
        public void KillProcess(string idkiller)
        {
            if (!string.IsNullOrEmpty(idkiller))
            {
                IdKillProcess = idkiller;
            }
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke(this, EventArgs.Empty);
    }
}
