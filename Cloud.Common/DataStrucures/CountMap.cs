using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.Common.DataStrucures
{
    public class CountMap
    {
        private Dictionary<string, int> _map;
        const int NumberOfChecksToActivate = 2; // Need to read from config

        public CountMap()
        {
            _map = new Dictionary<string, int>();
        }

        public void Deactivate(string key)
        {
            _map[key] = NumberOfChecksToActivate;
        }

        public void Activate(string key)
        {
            if (_map.ContainsKey(key))
                _map[key]--;
        }
        public void ResetAll()
        {
            foreach (var key in _map.Keys)
            {
                _map[key] = 0;
            }
        }

        public IEnumerable<string> GetAll()
        {
            var result = new List<string>();

            foreach (var key in _map.Keys)
            {
                result.Add(key);
            }

            return result;
        }

        private IEnumerable<string> GetItemsPassedThreshold()
        {
            var result = new List<string>();

            foreach (var key in _map.Keys)
            {
                if (_map[key] == 0)
                {
                    result.Add(key);
                }
            }
            return result;
        }

        public IEnumerable<string> PullActivatedItems()
        {
            var result = GetItemsPassedThreshold();
            foreach (var key in result)
            {
                if (_map.ContainsKey(key))
                {
                    _map.Remove(key);
                }
            }
            return result;
        }
    }
}
