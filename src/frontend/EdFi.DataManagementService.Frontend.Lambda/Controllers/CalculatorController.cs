// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Microsoft.AspNetCore.Mvc;

namespace EdFi.DataManagementService.Frontend.Lambda.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Perform x + y
    /// </summary>
    /// <param name="x">Left hand operand of the arithmetic operation.</param>
    /// <param name="y">Right hand operand of the arithmetic operation.</param>
    /// <returns>Sum of x and y.</returns>
    [HttpGet("add/{x}/{y}")]
    public int Add(int x, int y)
    {
        _logger.LogInformation($"{x} plus {y} is {x + y}");
        return x + y;
    }

    /// <summary>
    /// Perform x - y.
    /// </summary>
    /// <param name="x">Left hand operand of the arithmetic operation.</param>
    /// <param name="y">Right hand operand of the arithmetic operation.</param>
    /// <returns>x subtract y</returns>
    [HttpGet("subtract/{x}/{y}")]
    public int Subtract(int x, int y)
    {
        _logger.LogInformation($"{x} subtract {y} is {x - y}");
        return x - y;
    }

    /// <summary>
    /// Perform x * y.
    /// </summary>
    /// <param name="x">Left hand operand of the arithmetic operation.</param>
    /// <param name="y">Right hand operand of the arithmetic operation.</param>
    /// <returns>x multiply y</returns>
    [HttpGet("multiply/{x}/{y}")]
    public int Multiply(int x, int y)
    {
        _logger.LogInformation($"{x} multiply {y} is {x * y}");
        return x * y;
    }

    /// <summary>
    /// Perform x / y.
    /// </summary>
    /// <param name="x">Left hand operand of the arithmetic operation.</param>
    /// <param name="y">Right hand operand of the arithmetic operation.</param>
    /// <returns>x divide y</returns>
    [HttpGet("divide/{x}/{y}")]
    public int Divide(int x, int y)
    {
        _logger.LogInformation($"{x} divide {y} is {x / y}");
        return x / y;
    }
}
