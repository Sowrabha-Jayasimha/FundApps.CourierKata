using FundApps.CourierKata.Models;

namespace FundApps.CourierKata.Services
{
    public interface IParcelService
    {
        Parcel CreateParcel(int length, int width, int height, int weight);
    }
}
