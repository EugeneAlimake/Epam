using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType _Miletarytype;

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType miletarytype)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            _Miletarytype = miletarytype;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   _Miletarytype == plane._Miletarytype;
        }

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + _Miletarytype.GetHashCode();
            return hashCode;
        }

        public MilitaryType GetMilitaryType()
        {
            return _Miletarytype;
        }


        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + _Miletarytype +
                    '}');
        }        
    }
}
