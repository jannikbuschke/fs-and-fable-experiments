// vite.config.js
import { defineConfig } from "vite";
import react from "@vitejs/plugin-react";

export default defineConfig({
  plugins: [
    react({
      jsxImportSource: "@emotion/react",
      // babel: {
      //   plugins: ["@emotion/babel-plugin"],
      // },
    }),
  ],
  build: {
    sourcemap: true,
    outDir: "../planner1/app/web/build/",
    target: "es2015",
    minify: false,
  },
  esbuild: {
    jsxFactory: `jsx`,
    logOverride: { "this-is-undefined-in-esm": "silent" },
    // jsxInject: `import { jsx, css } from '@emotion/react'`,
  },
  optimizeDeps: {
    include: ["react/jsx-runtime"],
  },
  server: {
    port: 3003,
    open: true
  },
});
