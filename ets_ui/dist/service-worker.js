if(!self.define){let e,s={};const i=(i,r)=>(i=new URL(i+".js",r).href,s[i]||new Promise((s=>{if("document"in self){const e=document.createElement("script");e.src=i,e.onload=s,document.head.appendChild(e)}else e=i,importScripts(i),s()})).then((()=>{let e=s[i];if(!e)throw new Error(`Module ${i} didn’t register its module`);return e})));self.define=(r,n)=>{const l=e||("document"in self?document.currentScript.src:"")||location.href;if(s[l])return;let c={};const o=e=>i(e,l),u={module:{uri:l},exports:c,require:o};s[l]=Promise.all(r.map((e=>u[e]||o(e)))).then((e=>(n(...e),c)))}}define(["./workbox-2d118ab0"],(function(e){"use strict";e.setCacheNameDetails({prefix:"ets_ui"}),self.addEventListener("message",(e=>{e.data&&"SKIP_WAITING"===e.data.type&&self.skipWaiting()})),e.precacheAndRoute([{url:"/css/721.aeebbaaf.css",revision:null},{url:"/css/732.ad32b49e.css",revision:null},{url:"/css/79.aeebbaaf.css",revision:null},{url:"/css/861.aeebbaaf.css",revision:null},{url:"/css/app.bc319aa1.css",revision:null},{url:"/ets-logo.png",revision:"3d75442351fe7c3fd4fcf8d6583ad492"},{url:"/img/25436.png",revision:"180110cfbc77e5acb0a3b782cd8ad40c"},{url:"/img/standart.png",revision:"cad2c2f69d46db31c3df0a72e9e14216"},{url:"/index.html",revision:"008613054a65ff22de4ec0931a5defb8"},{url:"/js/380.7a4950f8.js",revision:null},{url:"/js/721.13bbca14.js",revision:null},{url:"/js/732.0acf24bf.js",revision:null},{url:"/js/79.eef9871d.js",revision:null},{url:"/js/861.b9d96804.js",revision:null},{url:"/js/app.1a47346f.js",revision:null},{url:"/js/chunk-vendors.dc227968.js",revision:null},{url:"/manifest.json",revision:"3066ed102ed7851cf1e1080e84a801ac"},{url:"/robots.txt",revision:"b6216d61c03e6ce0c9aea6ca7808f7ca"}],{})}));
//# sourceMappingURL=service-worker.js.map
