using System;
using System.Runtime.Serialization;

namespace wa02.Models {
    [Serializable]
    internal class UpdateConcurrencyException : Exception {
        public UpdateConcurrencyException() {
        }

        public UpdateConcurrencyException(string message) : base(message) {
        }

        public UpdateConcurrencyException(string message, Exception innerException) : base(message, innerException) {
        }

        protected UpdateConcurrencyException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}