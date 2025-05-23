﻿namespace OKX.Api.Account;

/// <summary>
/// Okx Auto Repay
/// </summary>
internal record OkxAccountAutoRepayContainer
{
    /// <summary>
    /// Auto Repay
    /// </summary>
    [JsonProperty("autoLoan")]
    public bool Payload { get; set; }
}