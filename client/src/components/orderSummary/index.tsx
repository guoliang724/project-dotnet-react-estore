import React from 'react'
import {Button, Card, Divider} from "antd"
import { useNavigate } from 'react-router-dom'
import { useAppSelector } from '../../store/slice';


function OrderSummary() {
  const navigtate = useNavigate();
  const {basket} = useAppSelector(state=>state.basket);
  const subtotal = Number(basket?.items.reduce((ac,cu)=>(cu.quantity * cu.price) + ac,0).toFixed(2));
  const disCount = Number((-0).toFixed(2));
  const deliveryFee = Number((+subtotal! > 100?0:5).toFixed(2));
  const totalCost = Number((subtotal! + disCount + deliveryFee).toFixed(2));

  const titleComponent = <div className='flex flex-col'>
    <div className='font-Rubik'>Order Summary</div>
    <span className='text-[14px] font-Assitant font-light italic tracking-wide'>orders over $100 qualify for free delivery</span>
    </div>

  return (
    <Card title={titleComponent} bordered={false}  className='p-5 w-72 bg-slate-50'>
      <div className='flex flex-col'>
         <div className='flex flex-col gap-2'>
             <div className='flex justify-between'><span>Subtotal: </span><span>{subtotal}</span></div>
             <div className='flex justify-between'><span>Discount: </span><span>-{disCount}</span></div>
             <div className='flex justify-between'><span>Delivery Fee: </span><span>{deliveryFee}</span></div>
             <div className='flex justify-between'><span>Total Cost: </span><span>{totalCost}</span></div>
         </div>
         <Divider></Divider>
          <div className='flex flex-col gap-5'>
          <div className='flex justify-between'><span>Total: </span><span>{}</span></div>
          <Button className='bg-[#262626] text-yellow-100' onClick={()=>navigtate("/checkout")}>CHECKOUT</Button>
          <Button type="link" onClick={()=>navigtate("/products")}>CONTINUE SHOPPING</Button>
          </div>
      </div>
    </Card>
  )
}

export default OrderSummary