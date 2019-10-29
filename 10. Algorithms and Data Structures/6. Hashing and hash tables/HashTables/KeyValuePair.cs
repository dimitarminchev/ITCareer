namespace HashTables
{
    public class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public KeyValuePair(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public override bool Equals(object other)
        {
            KeyValuePair<TKey, TValue> element = (KeyValuePair<TKey, TValue>) other;
            bool areEqual = Equals(this.Key, element.Key) && Equals(this.Value, element.Value);
            return areEqual;
        }

        public override int GetHashCode()
        {
            int keyHashCode = this.Key.GetHashCode();
            int valueHashCode = this.Value.GetHashCode();
            int keyValuePairHashCode = ((keyHashCode << 5) + keyHashCode) ^ valueHashCode;
            return keyValuePairHashCode;
        }

        public override string ToString()
        {
            return $"[{this.Key} -> {this.Value}]";
        }
    }
}
