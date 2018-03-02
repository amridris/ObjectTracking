#pragma once
namespace ObjectTrackingDB {
	class StoreItem
	{
	private:
		int item_number;
	public:
		StoreItem(int item_number = 0);
		~StoreItem();
		inline int getItemNumber() const { return item_number; };
		void setItemNumber(int arg_item_number = 1);
	};
}
