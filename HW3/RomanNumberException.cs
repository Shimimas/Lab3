using System;

namespace HW3 {
    public class RomanNumberException : Exception {
        public RomanNumberException() : base() { }
        public RomanNumberException(string message) : base(message) { }
    }
}