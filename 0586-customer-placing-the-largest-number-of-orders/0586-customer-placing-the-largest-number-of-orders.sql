/* Write your T-SQL query statement below */
select Top 1 customer_number
from orders 
group by customer_number
order by Count(*) desc
