namespace api.DTOs;

public record VerifyRequest(
    string Address,
    string Message,
    string Signature,
    string? Email
);