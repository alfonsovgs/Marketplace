using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Domain
{
    public class ClassifiedAd
    {
        public Guid Id { get; private set; }

        public ClassifiedAd(Guid id, Guid ownerId)
        {
            if(id == default) throw new ArgumentException("Identity must be specified", nameof(id));
            Id = id;
            _ownerId = ownerId;
        }

        public void SetTitle(string title) => _title = title;
        public void UpdateText(string text) => _text = text;
        public void UpdatePrice(decimal price) => _price = price;

        private Guid _ownerId;
        private string _title;
        private string _text;
        private decimal _price;
    }
}
