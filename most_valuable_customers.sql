select top (20) dummy2.first_name, dummy2.last_name, dummy2.city, dummy2.state,dummy1.total_customer_sales from sales.customers as dummy2
left join (select cust.customer_id, sum(items_2.total_order_price) as total_customer_sales from sales.customers as cust 
left join sales.orders as ord on ord.customer_id = cust.customer_id
left join sales.order_items as items on ord.order_id = items.order_id 
left join(SELECT items_2.order_id, sum(items_2.list_price*(1-items_2.discount)) as total_order_price --total sales 
from sales.order_items as items_2
group by items_2.order_id) as items_2 on ord.order_id = items_2.order_id
group by cust.customer_id) as dummy1 on dummy1.customer_id=dummy2.customer_id 
order by dummy1.total_customer_sales desc;

/*cust.first_name, cust.last_name, ord.order_id, */