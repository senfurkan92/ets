"use strict";(self["webpackChunkets_ui"]=self["webpackChunkets_ui"]||[]).push([[79],{5686:function(t,e,a){a.d(e,{Z:function(){return N}});var i=a(3396),s=a(2268);const l=t=>((0,i.dD)("data-v-9ef3fd8e"),t=t(),(0,i.Cn)(),t),r={class:"card md:card-side card-compact bg-base-100 border border-base-300 hover:shadow-2xl h-full hover:bg-base-200"},n={style:{height:"280px",width:"200px"}},c=["src"],o={class:"card-body",style:{width:"300px"}},d={class:"card-title text-2xl font-navigation capitalize text-error"},m={class:"flex flex-row items-center mb-4"},u={class:"mr-4"},v={class:"text-6xl font-bold"},f={class:"mr-4 text-center"},_={class:"text-xl font-bold"},y=l((()=>(0,i._)("br",null,null,-1))),g={class:"text-xl font-bold"},w={class:"mr-4 text-center"},p={class:"text-xl font-bold"},x=l((()=>(0,i._)("br",null,null,-1))),b={class:"text-xl font-bold"},h={class:"capitalize font-bold text-2xl"},D={class:"card-actions justify-end"},k=(0,i.Uk)(" Detay ");var z={__name:"ActivityCard",props:{item:{type:Object,required:!0}},setup(t){const e=t;return(t,a)=>{const l=(0,i.up)("router-link");return(0,i.wg)(),(0,i.iD)("div",r,[(0,i._)("figure",null,[(0,i._)("div",n,[(0,i.Wm)(l,{to:{name:"Activity",params:{categoryName:e.item.category.name,categoryId:e.item.categoryId,activityName:e.item.title,activityId:e.item.id}}},{default:(0,i.w5)((()=>[(0,i._)("img",{src:e.item.posterPath||"/img/standart.png",alt:"Movie",class:"h-full w-full object-contain"},null,8,c)])),_:1},8,["to"])])]),(0,i._)("div",o,[(0,i._)("h2",d,(0,s.zw)(e.item.title),1),(0,i._)("div",null,[(0,i._)("div",m,[(0,i._)("div",u,[(0,i._)("span",v,(0,s.zw)(new Date(e.item.startDate).getDate()),1)]),(0,i._)("div",f,[(0,i._)("span",_,(0,s.zw)(new Date(e.item.startDate).toLocaleString("tr",{month:"short"})),1),y,(0,i._)("span",g,(0,s.zw)(new Date(e.item.startDate).getFullYear()),1)]),(0,i._)("div",w,[(0,i._)("span",p,(0,s.zw)(new Date(e.item.startDate).toLocaleString("tr",{weekday:"short"})),1),x,(0,i._)("span",b,(0,s.zw)(new Date(e.item.startDate).toLocaleTimeString("tr",{hour:"2-digit",minute:"2-digit"})),1)])]),(0,i._)("div",h,(0,s.zw)(e.item.city),1)]),(0,i._)("div",D,[(0,i.Wm)(l,{to:{name:"Activity",params:{categoryName:e.item.category.name,categoryId:e.item.categoryId,activityName:e.item.title,activityId:e.item.id}},class:"btn btn-secondary"},{default:(0,i.w5)((()=>[k])),_:1},8,["to"])])])])}}},L=a(89);const I=(0,L.Z)(z,[["__scopeId","data-v-9ef3fd8e"]]);var N=I},79:function(t,e,a){a.r(e),a.d(e,{default:function(){return m}});var i=a(3396),s=a(5686),l=a(7139);const r=(0,i._)("div",{class:"text-center mb-10"},[(0,i._)("h2",{class:"text-4xl font-semibold font-title tracking-widest"}," GEÇMİŞ ETKİNLİKLER ")],-1),n={class:"flex flex-wrap justify-center"},c={key:0};var o={__name:"PastView",setup(t){const e=(0,l.oR)();return(0,i.bv)((()=>{e.dispatch("activity/fetchFilteredList",{active:!1})})),(t,e)=>((0,i.wg)(),(0,i.iD)(i.HY,null,[r,(0,i._)("div",n,[t.$store.state.activity.filteredList.length<1?((0,i.wg)(),(0,i.iD)("div",c," Etkinlik bulunamadı. ")):(0,i.kq)("",!0),((0,i.wg)(!0),(0,i.iD)(i.HY,null,(0,i.Ko)(t.$store.state.activity.filteredList,(t=>((0,i.wg)(),(0,i.iD)("div",{key:t.id,class:"py-2 px-2"},[(0,i.Wm)(s.Z,{item:t},null,8,["item"])])))),128))])],64))}};const d=o;var m=d}}]);
//# sourceMappingURL=79.b241eb94.js.map