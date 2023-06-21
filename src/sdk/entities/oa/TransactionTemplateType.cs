using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class TransactionTemplateType
    {
        private string value;

        private TransactionTemplateType(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static TransactionTemplateType TRANSACTION_BILLING = new TransactionTemplateType("transaction_billing");
        public static TransactionTemplateType TRANSACTION_ORDER = new TransactionTemplateType("transaction_order");
        public static TransactionTemplateType TRANSACTION_REWARD = new TransactionTemplateType("transaction_reward");
        public static TransactionTemplateType TRANSACTION_CONTRACT = new TransactionTemplateType("transaction_contract");
        public static TransactionTemplateType TRANSACTION_BOOKING = new TransactionTemplateType("transaction_booking");
        public static TransactionTemplateType TRANSACTION_MEMBERSHIP = new TransactionTemplateType("transaction_membership");
        public static TransactionTemplateType TRANSACTION_EVENT = new TransactionTemplateType("transaction_event");
        public static TransactionTemplateType TRANSACTION_TRANSACTION = new TransactionTemplateType("transaction_transaction");
        public static TransactionTemplateType TRANSACTION_ACCOUNT = new TransactionTemplateType("transaction_account");
        public static TransactionTemplateType TRANSACTION_INTERNAL = new TransactionTemplateType("transaction_internal");
        public static TransactionTemplateType TRANSACTION_PARTNERSHIP = new TransactionTemplateType("transaction_partnership");
        public static TransactionTemplateType TRANSACTION_EDUCATION = new TransactionTemplateType("transaction_transaction");
        public static TransactionTemplateType TRANSACTION_RATING = new TransactionTemplateType("transaction_rating");

    }
}
