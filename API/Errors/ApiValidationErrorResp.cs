using System.Collections.Generic;

namespace API.Errors
{
	public class ApiValidationErrorResp : ApiResponse
	{
		public ApiValidationErrorResp() : base(400)
		{
		}

		public IEnumerable<string> Errors { get; set; }
	}
}
