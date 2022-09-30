using Application.Common.Models;

namespace WebAPI.Models
{
    public enum EstadoRespuesta { Error = 0, Correcta, Parcial}
    public class ApiResponse<T>
    {
        public EstadoRespuesta Status { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
        
        public ApiResponse()
        {
            Status = EstadoRespuesta.Correcta;
        }
        
        public ApiResponse(T responseElement)
        {
            Status = EstadoRespuesta.Correcta;
            Data = responseElement;
            Message = string.Empty;
        }

        public ApiResponse(T responseElement, string message)
        {
            Status = EstadoRespuesta.Parcial;
            Data = responseElement;
            Message = message;
        }

        public ApiResponse(string message)
        {
            Status = EstadoRespuesta.Error;
            Message = message;
        }
    }
}
