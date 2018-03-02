#include "StoreItem.h"

namespace ObjectTrackingDB {
	StoreItem::StoreItem(int item_number)
		:item_number(item_number)
	{
	}

	void StoreItem::setItemNumber(int arg_item_number)
	{
		item_number = arg_item_number;
	}


	StoreItem::~StoreItem()
	{
	}
}
