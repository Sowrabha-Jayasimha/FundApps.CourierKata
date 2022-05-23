# FundApps.CourierKata

Few considerations and assumptions made: 
1. Have considered parcel dimensions and weight as integers 
2. Assumed heavy weight ranges between 30 and 50, as XL parcel (10 kg) with 20 kg overweight will cost $50.
3. Have arranged parcels in descending order of TotalCost as the one with least price should be marked as free.
4. The example given in the test description says that in Mixed mania first discount should be of $8 and second one should be $10. But as I have ordered parcels in descending order of TotalCost, first discount will be $10 and second one will be $8. The end result will be the same. Idea was to select parcel with lowest price.
