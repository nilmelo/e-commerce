using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            this.StatusCode = statusCode;
            this.Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

		public int StatusCode { get; set; }
		public string Message { get; set; }

		private string GetDefaultMessageForStatusCode(int statusCode)
		{
			return statusCode switch
			{
				400 => "Requisição não encontrada",
				401 => "Não Autorizado",
				404 => "Recurso não encontrado",
				500 => "Ocorreu um erro no servidor, tente novamente mais tarde",
				_ => null
			};
		}
    }
}
