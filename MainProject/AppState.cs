namespace MainProject
{
	public class AppState
	{
		public event Action<(bool success, string username)> OnLoginStatusChanged;

		private bool loginSuccess;
		private string username;

		public bool LoginSuccess
		{
			get => loginSuccess;
			set
			{
				loginSuccess = value;
				OnLoginStatusChanged?.Invoke((loginSuccess, username));
			}
		}

		public string Username
		{
			get => username;
			set
			{
				username = value;
				OnLoginStatusChanged?.Invoke((loginSuccess, username));
			}
		}
	}
}
