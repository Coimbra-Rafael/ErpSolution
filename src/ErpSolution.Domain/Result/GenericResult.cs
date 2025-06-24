namespace ErpSolution.Domain.Result;

public class GenericResult
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public object Data { get; set; } = null!;
}