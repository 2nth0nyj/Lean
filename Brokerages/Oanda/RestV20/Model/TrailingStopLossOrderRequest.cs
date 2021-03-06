/* 
 * OANDA v20 REST API
 *
 * The full OANDA v20 REST API Specification. This specification defines how to interact with v20 Accounts, Trades, Orders, Pricing and more.
 *
 * OpenAPI spec version: 3.0.15
 * Contact: api@oanda.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Oanda.RestV20.Model
{
    /// <summary>
    /// A TrailingStopLossOrderRequest specifies the parameters that may be set when creating a Trailing Stop Loss Order.
    /// </summary>
    [DataContract]
    public partial class TrailingStopLossOrderRequest :  IEquatable<TrailingStopLossOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of the Order to Create. Must be set to \"TRAILING_STOP_LOSS\" when creating a Trailng Stop Loss Order.
        /// </summary>
        /// <value>The type of the Order to Create. Must be set to \"TRAILING_STOP_LOSS\" when creating a Trailng Stop Loss Order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum MARKET for "MARKET"
            /// </summary>
            [EnumMember(Value = "MARKET")]
            MARKET,
            
            /// <summary>
            /// Enum LIMIT for "LIMIT"
            /// </summary>
            [EnumMember(Value = "LIMIT")]
            LIMIT,
            
            /// <summary>
            /// Enum STOP for "STOP"
            /// </summary>
            [EnumMember(Value = "STOP")]
            STOP,
            
            /// <summary>
            /// Enum MARKETIFTOUCHED for "MARKET_IF_TOUCHED"
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED")]
            MARKETIFTOUCHED,
            
            /// <summary>
            /// Enum TAKEPROFIT for "TAKE_PROFIT"
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT")]
            TAKEPROFIT,
            
            /// <summary>
            /// Enum STOPLOSS for "STOP_LOSS"
            /// </summary>
            [EnumMember(Value = "STOP_LOSS")]
            STOPLOSS,
            
            /// <summary>
            /// Enum TRAILINGSTOPLOSS for "TRAILING_STOP_LOSS"
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS")]
            TRAILINGSTOPLOSS
        }

        /// <summary>
        /// The time-in-force requested for the TrailingStopLoss Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for TrailingStopLoss Orders.
        /// </summary>
        /// <value>The time-in-force requested for the TrailingStopLoss Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for TrailingStopLoss Orders.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeInForceEnum
        {
            
            /// <summary>
            /// Enum GTC for "GTC"
            /// </summary>
            [EnumMember(Value = "GTC")]
            GTC,
            
            /// <summary>
            /// Enum GTD for "GTD"
            /// </summary>
            [EnumMember(Value = "GTD")]
            GTD,
            
            /// <summary>
            /// Enum GFD for "GFD"
            /// </summary>
            [EnumMember(Value = "GFD")]
            GFD,
            
            /// <summary>
            /// Enum FOK for "FOK"
            /// </summary>
            [EnumMember(Value = "FOK")]
            FOK,
            
            /// <summary>
            /// Enum IOC for "IOC"
            /// </summary>
            [EnumMember(Value = "IOC")]
            IOC
        }

        /// <summary>
        /// Specification of what component of a price should be used for comparison when determining if the Order should be filled.
        /// </summary>
        /// <value>Specification of what component of a price should be used for comparison when determining if the Order should be filled.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TriggerConditionEnum
        {
            
            /// <summary>
            /// Enum DEFAULT for "DEFAULT"
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            DEFAULT,
            
            /// <summary>
            /// Enum TRIGGERDEFAULT for "TRIGGER_DEFAULT"
            /// </summary>
            [EnumMember(Value = "TRIGGER_DEFAULT")]
            TRIGGERDEFAULT,
            
            /// <summary>
            /// Enum INVERSE for "INVERSE"
            /// </summary>
            [EnumMember(Value = "INVERSE")]
            INVERSE,
            
            /// <summary>
            /// Enum BID for "BID"
            /// </summary>
            [EnumMember(Value = "BID")]
            BID,
            
            /// <summary>
            /// Enum ASK for "ASK"
            /// </summary>
            [EnumMember(Value = "ASK")]
            ASK,
            
            /// <summary>
            /// Enum MID for "MID"
            /// </summary>
            [EnumMember(Value = "MID")]
            MID
        }

        /// <summary>
        /// The type of the Order to Create. Must be set to \"TRAILING_STOP_LOSS\" when creating a Trailng Stop Loss Order.
        /// </summary>
        /// <value>The type of the Order to Create. Must be set to \"TRAILING_STOP_LOSS\" when creating a Trailng Stop Loss Order.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The time-in-force requested for the TrailingStopLoss Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for TrailingStopLoss Orders.
        /// </summary>
        /// <value>The time-in-force requested for the TrailingStopLoss Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for TrailingStopLoss Orders.</value>
        [DataMember(Name="timeInForce", EmitDefaultValue=false)]
        public TimeInForceEnum? TimeInForce { get; set; }
        /// <summary>
        /// Specification of what component of a price should be used for comparison when determining if the Order should be filled.
        /// </summary>
        /// <value>Specification of what component of a price should be used for comparison when determining if the Order should be filled.</value>
        [DataMember(Name="triggerCondition", EmitDefaultValue=false)]
        public TriggerConditionEnum? TriggerCondition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrailingStopLossOrderRequest" /> class.
        /// </summary>
        /// <param name="Type">The type of the Order to Create. Must be set to \&quot;TRAILING_STOP_LOSS\&quot; when creating a Trailng Stop Loss Order..</param>
        /// <param name="TradeID">The ID of the Trade to close when the price threshold is breached..</param>
        /// <param name="ClientTradeID">The client ID of the Trade to be closed when the price threshold is breached..</param>
        /// <param name="Distance">The price distance specified for the TrailingStopLoss Order..</param>
        /// <param name="TimeInForce">The time-in-force requested for the TrailingStopLoss Order. Restricted to \&quot;GTC\&quot;, \&quot;GFD\&quot; and \&quot;GTD\&quot; for TrailingStopLoss Orders..</param>
        /// <param name="GtdTime">The date/time when the StopLoss Order will be cancelled if its timeInForce is \&quot;GTD\&quot;..</param>
        /// <param name="TriggerCondition">Specification of what component of a price should be used for comparison when determining if the Order should be filled..</param>
        /// <param name="ClientExtensions">ClientExtensions.</param>
        public TrailingStopLossOrderRequest(TypeEnum? Type = default(TypeEnum?), string TradeID = default(string), string ClientTradeID = default(string), string Distance = default(string), TimeInForceEnum? TimeInForce = default(TimeInForceEnum?), string GtdTime = default(string), TriggerConditionEnum? TriggerCondition = default(TriggerConditionEnum?), ClientExtensions ClientExtensions = default(ClientExtensions))
        {
            this.Type = Type;
            this.TradeID = TradeID;
            this.ClientTradeID = ClientTradeID;
            this.Distance = Distance;
            this.TimeInForce = TimeInForce;
            this.GtdTime = GtdTime;
            this.TriggerCondition = TriggerCondition;
            this.ClientExtensions = ClientExtensions;
        }
        
        /// <summary>
        /// The ID of the Trade to close when the price threshold is breached.
        /// </summary>
        /// <value>The ID of the Trade to close when the price threshold is breached.</value>
        [DataMember(Name="tradeID", EmitDefaultValue=false)]
        public string TradeID { get; set; }
        /// <summary>
        /// The client ID of the Trade to be closed when the price threshold is breached.
        /// </summary>
        /// <value>The client ID of the Trade to be closed when the price threshold is breached.</value>
        [DataMember(Name="clientTradeID", EmitDefaultValue=false)]
        public string ClientTradeID { get; set; }
        /// <summary>
        /// The price distance specified for the TrailingStopLoss Order.
        /// </summary>
        /// <value>The price distance specified for the TrailingStopLoss Order.</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public string Distance { get; set; }
        /// <summary>
        /// The date/time when the StopLoss Order will be cancelled if its timeInForce is \&quot;GTD\&quot;.
        /// </summary>
        /// <value>The date/time when the StopLoss Order will be cancelled if its timeInForce is \&quot;GTD\&quot;.</value>
        [DataMember(Name="gtdTime", EmitDefaultValue=false)]
        public string GtdTime { get; set; }
        /// <summary>
        /// Gets or Sets ClientExtensions
        /// </summary>
        [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
        public ClientExtensions ClientExtensions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrailingStopLossOrderRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TradeID: ").Append(TradeID).Append("\n");
            sb.Append("  ClientTradeID: ").Append(ClientTradeID).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
            sb.Append("  TriggerCondition: ").Append(TriggerCondition).Append("\n");
            sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TrailingStopLossOrderRequest);
        }

        /// <summary>
        /// Returns true if TrailingStopLossOrderRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TrailingStopLossOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrailingStopLossOrderRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.TradeID == other.TradeID ||
                    this.TradeID != null &&
                    this.TradeID.Equals(other.TradeID)
                ) && 
                (
                    this.ClientTradeID == other.ClientTradeID ||
                    this.ClientTradeID != null &&
                    this.ClientTradeID.Equals(other.ClientTradeID)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.TimeInForce == other.TimeInForce ||
                    this.TimeInForce != null &&
                    this.TimeInForce.Equals(other.TimeInForce)
                ) && 
                (
                    this.GtdTime == other.GtdTime ||
                    this.GtdTime != null &&
                    this.GtdTime.Equals(other.GtdTime)
                ) && 
                (
                    this.TriggerCondition == other.TriggerCondition ||
                    this.TriggerCondition != null &&
                    this.TriggerCondition.Equals(other.TriggerCondition)
                ) && 
                (
                    this.ClientExtensions == other.ClientExtensions ||
                    this.ClientExtensions != null &&
                    this.ClientExtensions.Equals(other.ClientExtensions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.TradeID != null)
                    hash = hash * 59 + this.TradeID.GetHashCode();
                if (this.ClientTradeID != null)
                    hash = hash * 59 + this.ClientTradeID.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.TimeInForce != null)
                    hash = hash * 59 + this.TimeInForce.GetHashCode();
                if (this.GtdTime != null)
                    hash = hash * 59 + this.GtdTime.GetHashCode();
                if (this.TriggerCondition != null)
                    hash = hash * 59 + this.TriggerCondition.GetHashCode();
                if (this.ClientExtensions != null)
                    hash = hash * 59 + this.ClientExtensions.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
