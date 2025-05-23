﻿namespace OKX.Api.Account;

/// <summary>
/// OKX Account Balance
/// </summary>
public record OkxAccountBalance
{
    /// <summary>
    /// Update time of account information, millisecond format of Unix timestamp, e.g. 1597026383085
    /// </summary>
    [JsonProperty("uTime")]
    public long UpdateTimestamp { get; set; }

    /// <summary>
    /// Update time of account information
    /// </summary>
    [JsonIgnore]
    public DateTime UpdateTime => UpdateTimestamp.ConvertFromMilliseconds();

    /// <summary>
    /// The total amount of equity in USD
    /// </summary>
    [JsonProperty("totalEq")]
    public decimal TotalEquity { get; set; }

    /// <summary>
    /// Isolated margin equity in USD
    /// Applicable to Single-currency margin and Multi-currency margin and Portfolio margin
    /// </summary>
    [JsonProperty("isoEq")]
    public decimal? IsolatedMarginEquity { get; set; }

    /// <summary>
    /// Adjusted / Effective equity in USD
    /// The net fiat value of the assets in the account that can provide margins for spot, futures, perpetual swap and options under the cross margin mode.
    /// Cause in multi-ccy or PM mode, the asset and margin requirement will all be converted to USD value to process the order check or liquidation.
    /// Due to the volatility of each currency market, our platform calculates the actual USD value of each currency based on discount rates to balance market risks.
    /// Applicable to Multi-currency margin and Portfolio margin
    /// </summary>
    [JsonProperty("adjEq")]
    public decimal? AdjustedEquity { get; set; }

    /// <summary>
    /// Cross margin frozen for pending orders in USD
    /// Only applicable to Multi-currency margin
    /// </summary>
    [JsonProperty("ordFroz")]
    public decimal? OrderFrozen { get; set; }

    /// <summary>
    /// Initial margin requirement in USD
    /// The sum of initial margins of all open positions and pending orders under cross margin mode in USD.
    /// Applicable to Multi-currency margin and Portfolio margin
    /// </summary>
    [JsonProperty("imr")]
    public decimal? IMR { get; set; }

    /// <summary>
    /// Maintenance margin requirement in USD
    /// The sum of maintenance margins of all open positions under cross margin mode in USD.
    /// Applicable to Multi-currency margin and Portfolio margin
    /// </summary>
    [JsonProperty("mmr")]
    public decimal? MMR { get; set; }

    /// <summary>
    /// Potential borrowing IMR of the account in USD
    /// Only applicable to Multi-currency margin and Portfolio margin.It is "" for other margin modes.
    /// </summary>
    [JsonProperty("borrowFroz")]
    public decimal? BorrowFrozen { get; set; }

    /// <summary>
    /// Margin ratio in USD
    /// The index for measuring the risk of a certain asset in the account.
    /// Applicable to Multi-currency margin and Portfolio margin
    /// </summary>
    [JsonProperty("mgnRatio")]
    public decimal? MarginRatio { get; set; }

    /// <summary>
    /// Notional value of positions in USD
    /// Applicable to Multi-currency margin and Portfolio margin
    /// </summary>
    [JsonProperty("notionalUsd")]
    public decimal? NotionalUsd { get; set; }

    /// <summary>
    /// Notional value for Borrow in USD
    /// Applicable to Spot mode/Multi-currency margin/Portfolio margin
    /// </summary>
    [JsonProperty("notionalUsdForBorrow")]
    public decimal? NotionalUsdForBorrow { get; set; }

    /// <summary>
    /// Notional value of positions for Perpetual Futures in USD
    /// Applicable to Multi-currency margin/Portfolio margin
    /// </summary>
    [JsonProperty("notionalUsdForSwap")]
    public decimal? NotionalUsdForSwap { get; set; }

    /// <summary>
    /// Notional value of positions for Expiry Futures in USD
    /// Applicable to Multi-currency margin/Portfolio margin
    /// </summary>
    [JsonProperty("notionalUsdForFutures")]
    public decimal? NotionalUsdForFutures { get; set; }

    /// <summary>
    /// Notional value of positions for Option in USD
    /// Applicable to Spot mode/Multi-currency margin/Portfolio margin
    /// </summary>
    [JsonProperty("notionalUsdForOption")]
    public decimal? NotionalUsdForOption { get; set; }

    /// <summary>
    /// Cross-margin info of unrealized profit and loss at the account level in USD
    /// Applicable to Multi-currency margin/Portfolio margin
    /// </summary>
    [JsonProperty("upl")]
    public decimal? UnrealizedProfitAndLoss { get; set; }

    /// <summary>
    /// Detailed asset information in all currencies
    /// </summary>
    [JsonProperty("details")]
    public List<OkxAccountBalanceDetails> Details { get; set; } = [];
}
