using System.ComponentModel.DataAnnotations;

namespace ClimateMonitor.Services.Models;

public class DeviceReadingRequest
{
    private const string regex = "^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.(0|[1-9]\\d*)(?:-((?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\\.(?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\\+([0-9a-zA-Z-]+(?:\\.[0-9a-zA-Z-]+)*))?$";

    [Required]
    [RegularExpression(regex, ErrorMessage = "The firmware value does not match semantic versioning format.")]
    public string FirmwareVersion { get; set; } = string.Empty;

    [Required]
    public decimal Temperature { get; set; }

    [Required]
    public decimal Humidity { get; set; }
}
