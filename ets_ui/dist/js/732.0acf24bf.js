"use strict";(self["webpackChunkets_ui"]=self["webpackChunkets_ui"]||[]).push([[732],{3977:function(e,t,l){l.d(t,{D:function(){return s},z:function(){return a}});const s=e=>{let t=e;const l={i:"İ","ş":"Ş","ğ":"Ğ","ü":"Ü","ö":"Ö","ç":"Ç","ı":"I"};return t=t.replace(/(([iışğüçö]))/g,(e=>l[e])),t.toUpperCase()},a=new Intl.NumberFormat("tr-TR",{style:"currency",currency:"TRY"})},6732:function(e,t,l){l.r(t),l.d(t,{default:function(){return ee}});var s=l(3396),a=l(2268),r=l(4870),n=l(8008),i=l(8170);const c={class:"body bg-gradient-to-b from-base-100 via-base-100 to-base-200 shadow-sm rounded-b-lg"},o=["src"];var d={__name:"ActivitySlider",props:{images:{type:Array}},setup(e){const t=e,l=[i.lI,i.tl];return(e,a)=>((0,s.wg)(),(0,s.iD)("div",c,[(0,s.Wm)((0,r.SU)(n.tq),{effect:"coverflow",grabCursor:!0,centeredSlides:!0,slidesPerView:"auto",coverflowEffect:{rotate:50,stretch:0,depth:100,modifier:1,slideShadows:!0},pagination:!0,modules:l,class:"mySwiper"},{default:(0,s.w5)((()=>[((0,s.wg)(!0),(0,s.iD)(s.HY,null,(0,s.Ko)(t.images,(e=>((0,s.wg)(),(0,s.j4)((0,r.SU)(n.o5),{key:e.id},{default:(0,s.w5)((()=>[(0,s._)("img",{class:"h-full w-full object-contain",src:e.path,alt:""},null,8,o)])),_:2},1024)))),128))])),_:1})]))}};const u=d;var p=u,m=l(3977),f=l(7139),w=l(678);const g={class:"text-center mb-10"},v={class:"text-4xl uppercase font-semibold font-title tracking-widest"},x={key:0,class:"grid grid-cols-4 gap-8"},b={class:"lg:col-span-1 md:col-span-2 col-span-4 flex justify-center"},_={class:"aspect-[5/7]",style:{width:"clamp(300px, 100%, 500px)"}},h=["src"],y={class:"lg:col-span-1 md:col-span-2 col-span-4 md:px-0 px-8"},D={class:"flex flex-row items-center mb-4"},z={class:"mr-4"},k={class:"text-8xl font-bold"},S={class:"mr-4 text-center"},j={class:"text-3xl font-bold"},U=(0,s._)("br",null,null,-1),T={class:"text-2xl font-bold"},A={class:"mr-4 text-center"},I={class:"text-3xl font-bold"},L=(0,s._)("br",null,null,-1),Y={class:"text-2xl font-bold"},C={style:{"max-width":"400px"}},H={class:"text-3xl font-bold text-error"},q=(0,s._)("br",null,null,-1),E={class:"text-2xl font-bold"},F=(0,s._)("br",null,null,-1),R=(0,s._)("br",null,null,-1),K={class:"italic"},N={class:"lg:col-span-2 lg:flex hidden justify-center"},P=["src"],V={class:"col-span-4 px-8 text-xl font-bold uppercase"},W={class:"col-span-4 px-8 text-lg"},B={class:"col-span-4 px-8"},$=(0,s._)("h3",{class:"text-xl font-bold"}," Bilet Fiyatları ",-1),G=(0,s._)("hr",null,null,-1),J={class:"font-bold capitalize"},M={key:0,class:"col-span-4 px-8"},O={class:"col-span-4 px-8 justify-center lg:hidden flex"},Q=["src"];var X={__name:"ActivityView",setup(e){const t=(0,f.oR)(),l=(0,w.yj)(),n=(0,r.iH)(null);return(0,s.bv)((()=>{t.dispatch("activity/fetchItem",l.params.activityId).then((e=>{e.data.success&&(n.value=e.data.result)}))})),(e,t)=>((0,s.wg)(),(0,s.iD)(s.HY,null,[(0,s._)("div",g,[(0,s._)("h2",v,(0,a.zw)((0,r.SU)(m.D)(e.$route.params.categoryName)),1)]),n.value?((0,s.wg)(),(0,s.iD)("div",x,[(0,s._)("div",b,[(0,s._)("div",_,[(0,s._)("img",{style:{filter:"drop-shadow(10px 0px 10px gray)"},class:"w-full h-full object-contain",src:n.value.posterPath||"/img/standart.png",alt:""},null,8,h)])]),(0,s._)("div",y,[(0,s._)("div",D,[(0,s._)("div",z,[(0,s._)("span",k,(0,a.zw)(new Date(n.value.startDate).getDay()),1)]),(0,s._)("div",S,[(0,s._)("span",j,(0,a.zw)(new Date(n.value.startDate).toLocaleString("tr",{month:"short"})),1),U,(0,s._)("span",T,(0,a.zw)(new Date(n.value.startDate).getFullYear()),1)]),(0,s._)("div",A,[(0,s._)("span",I,(0,a.zw)(new Date(n.value.startDate).toLocaleString("tr",{weekday:"short"})),1),L,(0,s._)("span",Y,(0,a.zw)(new Date(n.value.startDate).toLocaleTimeString("tr",{hour:"2-digit",minute:"2-digit"})),1)])]),(0,s._)("div",C,[(0,s._)("span",H,(0,a.zw)(n.value.placeTitle)+",",1),q,(0,s._)("span",E,(0,a.zw)(n.value.city),1),F,R,(0,s._)("span",K,(0,a.zw)(n.value.address),1)])]),(0,s._)("div",N,[(0,s._)("iframe",{title:"",src:n.value.mapLocation||"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d24483.207286767785!2d32.760805773334596!3d39.9100435019644!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d3489dbdce88e5%3A0x3b7ba3b8611e1e12!2sEts%20Tur!5e0!3m2!1str!2str!4v1655844892790!5m2!1str!2str",width:"600",height:"450",style:{border:"0"},allowfullscreen:"",loading:"lazy",referrerpolicy:"no-referrer-when-downgrade"},null,8,P)]),(0,s._)("div",V,(0,a.zw)((0,r.SU)(m.D)(n.value.title)),1),(0,s._)("div",W,(0,a.zw)(n.value.description),1),(0,s._)("div",B,[$,G,(0,s._)("ul",null,[((0,s.wg)(!0),(0,s.iD)(s.HY,null,(0,s.Ko)(n.value.tickets,(e=>((0,s.wg)(),(0,s.iD)("li",{key:e.id},[(0,s._)("span",J,(0,a.zw)(e.title),1),(0,s.Uk)(": "+(0,a.zw)((0,r.SU)(m.z).format(e.fee)),1)])))),128))])]),n.value.images?((0,s.wg)(),(0,s.iD)("div",M,[(0,s.Wm)(p,{images:n.value.images},null,8,["images"])])):(0,s.kq)("",!0),(0,s._)("div",O,[(0,s._)("iframe",{title:"",src:n.value.mapLocation||"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d24483.207286767785!2d32.760805773334596!3d39.9100435019644!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d3489dbdce88e5%3A0x3b7ba3b8611e1e12!2sEts%20Tur!5e0!3m2!1str!2str!4v1655844892790!5m2!1str!2str",width:"600",height:"450",style:{border:"0"},allowfullscreen:"",loading:"lazy",referrerpolicy:"no-referrer-when-downgrade"},null,8,Q)])])):(0,s.kq)("",!0)],64))}};const Z=X;var ee=Z}}]);
//# sourceMappingURL=732.0acf24bf.js.map